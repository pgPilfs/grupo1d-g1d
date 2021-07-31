import { Component, OnInit } from '@angular/core';
import { Validators, FormControl } from '@angular/forms';


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


  constructor() {}
  
  
  ngOnInit(): void {
  }
  

  get mailField(){
    return this.mail;
  }

  get passwordField(){
    return this.password;
  }

}
