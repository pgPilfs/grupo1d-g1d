import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})


export class ClienteService {
  url="https://localhost:44350/api/cliente";  
  constructor(private http:HttpClient) { } //Inyecto el Http Client en el constructor de mi servicio, para hacer llamadas http

  onCrearRegistro(cliente:Persona):Observable<Persona>{   //por parametros recibe un objto persona que la profe lo llama usuario yo le pongo cliente
    return this.http.post<Persona>(this.url, cliente); //llamo a la api pasandole la ruta y el objeto 
  }
}

export class Persona
{
  IdCliente:number=0;
  nombre:string="";  
  apellido:string="";
  ciudad:string="";
  cP:string="";
  provincia:string="";
  nombreUsuario:string="";
  dni:string="";
  email:string="";
  fotoDni:string="";
  password:string="";
  password2:string=""
  
  //A modo de ejemplo se deja así pero lo ideal es crear propiedades para acceder a los atributos.
}

export class  LoginRequest {
  UserName:string="";
  Password:string="";
  Token: string="";
}
