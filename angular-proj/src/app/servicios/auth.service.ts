import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
//import { LoginRequest } from '../../servicios/cliente.service';
import { LoginRequest } from '../../app/modelos/login.interface';
import { ResponseI } from '../../app/modelos/response.interface';
import {HttpClient} from '@angular/common/http';
const TOKEN_KEY = 'auth-token';

@Injectable({
  providedIn: 'root'
})

export class AuthService {
  url="https://localhost:44350/api/login/authenticate";
  currentUserSubject: BehaviorSubject<LoginRequest>;
  currentUser: Observable<LoginRequest>;
  loggedIn= new BehaviorSubject<boolean>(false);

  constructor(private http:HttpClient) {
    console.log("AUTH SERVICE WORKING");
    //let dataResponse: ResponseI = data;
    this.currentUserSubject = new  BehaviorSubject<LoginRequest>(JSON.parse(localStorage.getItem(TOKEN_KEY) || '{}'));
    //localStorage.setItem(TOKEN_KEY,ResponseI);
    // localStorage.getItem(TOKEN_KEY) --> te devuelve un string que corresponde al token, 
    // no un objeto completo que coincida con LoginRequest
    this.currentUser = this.currentUserSubject.asObservable();
    // loginByEmail(form:LoginRequest):Observable<ResponseI>{
    //   let direccion = this.url + "auth";
    //   return this.http.post<ResponseI>(direccion,form);
    // }
    
 
  }

  login(usuario: LoginRequest): Observable<any> {
    return this.http.post<LoginRequest>(this.url, usuario).pipe(map(data => {
      // localStorage.setItem(TOKEN_KEY, data.Token);
      console.log(data);
      if (data.Token)
      {
        console.log("ESTOY ACA"+data.idCliente);
        localStorage.setItem(TOKEN_KEY, data.Token);
      }
                        
      this.currentUserSubject.next(data);
      this.loggedIn.next(true);
      return data;
    }));
  }

  get usuarioAutenticado(): LoginRequest {
    return this.currentUserSubject.value;
  }

  get estaAutenticado(): Observable<boolean> {
    return this.loggedIn.asObservable();
  }

   logOut(): void {
    window.sessionStorage.clear();
    localStorage.removeItem(TOKEN_KEY);
    this.loggedIn.next(false);
  }
}

 
