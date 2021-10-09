import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GiroDescubiertoComponent } from './operatoria-pesos/giro-descubierto/giro-descubierto.component';
import { IngresoPesosComponent } from './operatoria-pesos/ingreso-pesos/ingreso-pesos.component';
import { RetiroPesosComponent } from './operatoria-pesos/retiro-pesos/retiro-pesos.component';
import { TransferenciasComponent } from './operatoria-pesos/transferencias/transferencias.component';
import { ConocenosComponent } from './pages/conocenos/conocenos.component';
import { HomeComponent } from './pages/home/home.component';
import { InicioSesionComponent } from './pages/inicio-sesion/inicio-sesion.component';
import { RegistrateComponent } from './pages/registrate/registrate.component';
import { PaginaPrincipalComponent } from './pages/pagina-principal/pagina-principal.component';
import {AuthGuard} from '../app/Servicios/auth.guard';
import { BilleteraComponent } from '../app/pages/billetera/billetera.component';
import { BilleteraOperatoriaComponent } from '../app/operatoria-pesos/billetera-operatoria/billetera-operatoria.component';

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'conocenos', component: ConocenosComponent},
  {path: 'iniciar-sesion', component: InicioSesionComponent},
  {path: 'billetera', component: BilleteraComponent ,  canActivate: [AuthGuard],
children:[
  {path: 'pagina-principal', component: PaginaPrincipalComponent}
]},

{path: 'billetera-operatoria', component: BilleteraOperatoriaComponent ,  canActivate: [AuthGuard],
children:[
  {path: 'giro-descubierto', component: GiroDescubiertoComponent},
  {path: 'ingreso-pesos', component: IngresoPesosComponent},
  {path: 'retiro-pesos', component: RetiroPesosComponent},
  {path: 'transferencias', component: TransferenciasComponent},
]},

// {path: 'pagina-principal', component: PaginaPrincipalComponent},
 
  {path: 'registrate', component: RegistrateComponent},  
  {path: " ", redirectTo: '/home', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
  
})
export class AppRoutingModule { }
