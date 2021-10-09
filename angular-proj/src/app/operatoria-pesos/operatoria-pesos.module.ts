import { NgModule, NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';

//Componentes
import { IngresoPesosComponent } from './ingreso-pesos/ingreso-pesos.component';
import { RetiroPesosComponent } from './retiro-pesos/retiro-pesos.component';
import { GiroDescubiertoComponent } from './giro-descubierto/giro-descubierto.component';
import { TransferenciasComponent } from './transferencias/transferencias.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BilleteraOperatoriaComponent } from './billetera-operatoria/billetera-operatoria.component';
import { AuthService } from '../Servicios/auth.service';
import {AuthGuard } from '../../app/Servicios/auth.guard';


@NgModule({
  declarations: [
    IngresoPesosComponent,
    RetiroPesosComponent,
    GiroDescubiertoComponent,
    TransferenciasComponent,
    BilleteraOperatoriaComponent
  ],
  imports: [
    CommonModule, FormsModule, ReactiveFormsModule
  ],
  exports: [IngresoPesosComponent, RetiroPesosComponent, GiroDescubiertoComponent, TransferenciasComponent],
  providers: [ AuthService, AuthGuard],
  schemas: [NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA]
})
export class OperatoriaPesosModule { }
