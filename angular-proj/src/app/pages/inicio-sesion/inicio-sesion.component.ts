import { Component, OnInit } from '@angular/core';
import { Validators, FormControl, FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginRequest } from '../../../servicios/cliente.service';
import { AuthService } from '../../src/app/servicios/auth.service';


@Component({
  selector: 'app-inicio-sesion',
  templateUrl: './inicio-sesion.component.html',
  styleUrls: ['./inicio-sesion.component.css']
})
export class InicioSesionComponent implements OnInit {
 
  emailPattern = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
  mail = new FormControl('', [Validators.required, Validators.pattern(this.emailPattern)]); 
  
  passwordPattern = "/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,15}/";
  password = new FormControl('', [Validators.required , Validators.pattern(this.passwordPattern), Validators.minLength(8)]); 

   
  
    form: FormGroup;
    usuario: LoginRequest = new LoginRequest(); 
    error: string="";

  constructor(private formBuilder: FormBuilder,private authService: AuthService,
    private router: Router) {
    this.form= this.formBuilder.group(
      {
        password:['',[Validators.required, Validators.minLength(8)]],
        mail:['', [Validators.required, Validators.email]]   
      }
    )

   }

  ngOnInit(): void {
  }

  get mailField()
  {
    return this.form.get("mail");
  }

  get passField()
  {
    return this.form.get("password");
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
    event.preventDefault(); //Cancela la funcionalidad por default.
    if (this.form.valid)
    {
      console.log(this.form.value); //se puede enviar al servidor...
      this.authService.login(this.usuario)
      .subscribe(
        data => {
        console.log("DATA"+ JSON.stringify( data));
        //localStorage.setItem('auth-token', JSON.stringify(data ));

        this.router.navigate(['mi-billetera/movimientos']);
       
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
