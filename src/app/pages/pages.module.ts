import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { InicioSesionComponent } from './inicio-sesion/inicio-sesion.component';
import { ConocenosComponent } from './conocenos/conocenos.component';
import { RegistrateComponent } from './registrate/registrate.component';
import { PaginaPrincipalComponent } from './pagina-principal/pagina-principal.component';
import { OperatoriaPesosModule } from '../operatoria-pesos/operatoria-pesos.module';



@NgModule({
  declarations: [
    HomeComponent,
    InicioSesionComponent,
    ConocenosComponent,
    RegistrateComponent,
    PaginaPrincipalComponent
  ],
  imports: [
    CommonModule,
    OperatoriaPesosModule
  
  ],    
  exports: [HomeComponent, InicioSesionComponent, ConocenosComponent,RegistrateComponent, PaginaPrincipalComponent ]
})
export class PagesModule { }
