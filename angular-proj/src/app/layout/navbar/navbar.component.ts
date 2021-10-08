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
  constructor(private authService: AuthService,private router: Router) { }

  ngOnInit(): void {
    this.authService.estaAutenticado.subscribe(res=>( this.estaAutenticado=res));
   }

   onCerrarSesion(){
    this.authService.logOut();
    this.estaAutenticado=false;
    this.router.navigate(['/iniciar-sesion']);
  }

}
