import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { InicioSesionComponent } from './inicio-sesion/inicio-sesion.component';
import { ConocenosComponent } from './conocenos/conocenos.component';
import { RegistrateComponent } from './registrate/registrate.component';



@NgModule({
  declarations: [
    HomeComponent,
    InicioSesionComponent,
    ConocenosComponent,
    RegistrateComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [HomeComponent, InicioSesionComponent, ConocenosComponent,RegistrateComponent]
})
export class PagesModule { }
