import { Component, OnInit } from '@angular/core';
import { Validators, FormControl, FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
//import { LoginRequest } from '../../../servicios/cliente.service';
import { AuthService } from '../../servicios/auth.service';
import { LoginRequest } from '../../modelos/login.interface';
import { ResponseI } from '../../modelos/response.interface';

@Component({
  selector: 'app-inicio-sesion',
  templateUrl: './inicio-sesion.component.html',
  styleUrls: ['./inicio-sesion.component.css']
})
export class InicioSesionComponent implements OnInit {

  form: FormGroup;  
  usuario: LoginRequest = new LoginRequest();
  error: string="";

    // emailPattern = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"; , Validators.pattern(this.emailPattern)
  // passwordPattern = "/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,15}/"; , Validators.pattern(this.passwordPattern)
  

  constructor(private formBuilder: FormBuilder, private authService: AuthService,
    private router: Router) {
    this.form= this.formBuilder.group(
      {
        mail:['', [Validators.required, Validators.email]]   ,
        password:['',[Validators.required, Validators.minLength(1)]]
        
      }
    )

   }

  ngOnInit(): void {
  }

  get mailField()
  {
    return this.form.controls.mail;
  }

  get passField()
  {
    return this.form.controls.password;
  }

  // get passInvalid()
  // {
  //   return this.passField.touched && !this.passField.valid;
  // }

  // get mailInvalid()
  // {
  //   return this.mailField.touched && !this.mailField.valid;
  // }

  onEnviar(event: Event, usuario: LoginRequest)
  {
    if (this.form.valid)
    {
      this.authService.login(this.usuario)
      .subscribe(
        data => {
        console.log("DATA"+ JSON.stringify( data));
        //localStorage.setItem('auth-token', JSON.stringify(data ));
        if ( this.authService.estaAutenticado) {
          this.router.navigate(['ingreso-pesos']);
               
        }
        
        },
        error => {
         this.error = error;
        }
      );
    }
    else
    {
      this.form.markAllAsTouched(); //Activa todas las validaciones
    }
  }
  
  // get mailField(){
  //   return this.mail;
  // }

  // get passwordField(){
  //   return this.password;
  // }




}
