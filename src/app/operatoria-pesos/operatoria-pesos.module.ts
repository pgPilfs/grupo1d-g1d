import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IngresoPesosComponent } from './ingreso-pesos/ingreso-pesos.component';
import { RetiroPesosComponent } from './retiro-pesos/retiro-pesos.component';
import { ConsultaSaldoComponent } from './consulta-saldo/consulta-saldo.component';
import { GiroDescubiertoComponent } from './giro-descubierto/giro-descubierto.component';
import { UltimasOperacionesComponent } from './ultimas-operaciones/ultimas-operaciones.component';
import { TransferenciasComponent } from './transferencias/transferencias.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    IngresoPesosComponent,
    RetiroPesosComponent,
    ConsultaSaldoComponent,
    GiroDescubiertoComponent,
    UltimasOperacionesComponent,
    TransferenciasComponent
  ],
  imports: [
    CommonModule, FormsModule, ReactiveFormsModule
  ],
  exports: [IngresoPesosComponent, RetiroPesosComponent, ConsultaSaldoComponent, GiroDescubiertoComponent, UltimasOperacionesComponent, TransferenciasComponent]
})
export class OperatoriaPesosModule { }
