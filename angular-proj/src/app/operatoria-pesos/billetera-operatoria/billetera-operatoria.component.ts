import { Component, NgModule, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AuthGuard } from '../../Servicios/auth.guard';
import { AuthService } from '../../Servicios/auth.service';


@Component({
  selector: 'app-billetera-operatoria',
  templateUrl: './billetera-operatoria.component.html',
  styleUrls: ['./billetera-operatoria.component.css'],
  providers: [ AuthService, AuthGuard ]

  
})


export class BilleteraOperatoriaComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
function routes(routes: any) {
  throw new Error('Function not implemented.');
}

