import { Component, OnInit } from '@angular/core';
import { ClienteService, Persona } from '../../../servicios/cliente.service';
import { FormBuilder, FormGroup, Validators, FormControl, AbstractControl, ValidationErrors } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-registrate',
  templateUrl: './registrate.component.html',
  styleUrls: ['./registrate.component.css']
})

export class RegistrateComponent implements OnInit {
  // mail = new FormControl('', [Validators.required, Validators.pattern(this.emailPattern)]); 
  //passwordPattern = "/^(?=\D*\d)(?=[^a-z]*[a-z])(?=[^A-Z]*[A-Z])$/";
  // password = new FormControl('', [Validators.required , Validators.pattern(this.passwordPattern), Validators.minLength(8)]); 
  form:FormGroup;
  cliente: Persona = new Persona();

  constructor(private formBuilder: FormBuilder, private ClienteService: ClienteService, private router: Router) {
    this.form= this.formBuilder.group(
      {
        
        nombre:['', [Validators.required]] ,
        apellido:['', [Validators.required]] ,
        ciudad:['', [Validators.required]] ,
        cP:['', [Validators.required]] ,
        provincia:['', [Validators.required]] ,
        nombreUsuario:['', [Validators.required]] ,
        dni:['', [Validators.required]] ,
        email:['', [Validators.required, Validators.email]],
        fotoDni:['', [Validators.required]] ,
        password:['', [Validators.required, Validators.minLength(6)]],
        password2:['', [Validators.required,  Validators.minLength(6)]]
        //, Validators.pattern(this.passwordPattern)
      }, 
       {
         validators: [RegistrateComponent.passwordMatchValidator],
       }
    )
   }

  ngOnInit(): void {
  }

  // get mailField(){
  //   return this.mail;
  // }

  // get passwordField(){
  //   return this.password;
  // }

  onEnviar(event: Event, cliente:Persona): void {
    event.preventDefault; 
 
    if (this.form.valid) // verifica que el formulario sea valido 
    {
      console.log(cliente); //logue en la consla como vienen los datos del usuario 
      this.ClienteService.onCrearRegistro(cliente).subscribe(
        data => {
          console.log(data);
           if (data['IdCliente']>0) //ESTO ME DA PROBLEMAS 
          {
            alert("El registro ha sido creado satisfactoriamente. A continuación, por favor Inicie Sesión.");
            this.router.navigate(['/iniciar-sesion'])
          }
      })
  }
  else
  {
    this.form.markAllAsTouched(); 
  }
};

static passwordMatchValidator(
  form: FormGroup,
) {
    const password: string = form.controls.password.value;
    const password2: string = form.controls.password2.value;
    if (password !== password2) {
      form.controls.password2.setErrors({ noPasswordMatch: true });
    } else {
      form.controls.password2.setErrors(null);
    }
}
//Tabla SQL de CLiente
get Nombre()
{
  return this.form.get("nombre");
}
get Apellido()
{
 return this.form.get("apellido");
}
get Ciudad()
{
 return this.form.get("Ciudad");
}
get CP()
{
 return this.form.get("cP");
}
get Provincia()
{
 return this.form.get("provincia");
}
get NombreUsuario()
{
 return this.form.get("nombreUsuario");
}
get Dni()
{
 return this.form.get("dni");
}
get Email()
{
 return this.form.get("email");
}
get FotoDni()
{
  return this.form.get("fotoDni");
}
get Password()
{
  return this.form.get("password");
}
get Password2()
{
  return this.form.get("password2");
}







get NombreValid()
{
  return this.Nombre?.touched && !this.Nombre?.valid;
}

get ApellidoValid()
{
  return this.Apellido?.touched && !this.Apellido?.valid;
}
get CiudadValid()
{
  return this.Ciudad?.touched && !this.Ciudad?.valid;
}

get CPValid()
{
  return this.CP?.touched && !this.CP?.valid;
}
get ProvinciaValid()
{
  return this.Provincia?.touched && !this.Provincia?.valid;
}

get NombreUsuarioValid()
{
  return this.NombreUsuario?.touched && !this.NombreUsuario?.valid;
}

get DniValid()
{
  return this.Dni?.touched && !this.Dni?.valid;
}
get EmailValid()
{
  return this.Email?.touched && !this.Email?.valid;
}
get FotoDniValid()
{
  return this.FotoDni?.touched && !this.FotoDni?.valid;
}
get PasswordValid()
{
  return this.Password?.touched && !this.Password?.valid;
}

get Password2Valid()
{
  return this.Password2?.touched && !this.Password2?.valid;
}



}
