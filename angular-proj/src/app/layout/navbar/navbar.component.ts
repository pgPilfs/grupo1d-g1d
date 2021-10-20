import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../Servicios/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  estaAutenticado:boolean=false;
  nombre:any;
  apellido:any;



  constructor(private authService: AuthService,private router: Router) { }

  ngOnInit(): void {

    this.nombre  = localStorage.getItem("Nombre");
    this.apellido  = localStorage.getItem("Apellido");
    // console.log("hola"+this.nombre+this.apellido)
    this.authService.estaAutenticado.subscribe(res=>( this.estaAutenticado=res));
   }

   onCerrarSesion(){
    this.authService.logOut();
    this.estaAutenticado=false;
    this.router.navigate(['/iniciar-sesion']);
  }

}
