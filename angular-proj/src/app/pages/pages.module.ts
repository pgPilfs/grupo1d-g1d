import { NgModule, NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { InicioSesionComponent } from './inicio-sesion/inicio-sesion.component';
import { ConocenosComponent } from './conocenos/conocenos.component';
import { RegistrateComponent } from './registrate/registrate.component';
import { PaginaPrincipalComponent } from '../pages/pagina-principal/pagina-principal.component';
import { OperatoriaPesosModule } from '../operatoria-pesos/operatoria-pesos.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BilleteraComponent } from './billetera/billetera.component';
import { AuthService } from '../Servicios/auth.service';
import { AuthGuard } from '../Servicios/auth.guard';




@NgModule({
  declarations: [
    HomeComponent,
    InicioSesionComponent,
    ConocenosComponent,
    RegistrateComponent,
    PaginaPrincipalComponent,
    BilleteraComponent
  ],
  imports: [
    CommonModule,
    OperatoriaPesosModule,
    ReactiveFormsModule,
    FormsModule


    
  
  ],    
  exports: [HomeComponent, InicioSesionComponent, ConocenosComponent,RegistrateComponent, PaginaPrincipalComponent ],
  schemas: [NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA],
  providers: [ AuthService, AuthGuard ]
})
export class PagesModule { }
