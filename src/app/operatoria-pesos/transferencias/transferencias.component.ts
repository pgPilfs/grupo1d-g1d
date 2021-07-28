import { Component, OnInit } from '@angular/core';
import { FormControl, Validators} from '@angular/forms';

@Component({
  selector: 'app-transferencias',
  templateUrl: './transferencias.component.html',
  styleUrls: ['./transferencias.component.css']
})
export class TransferenciasComponent implements OnInit {
  alias:string = "MANZANA.PELOTA.MANO"

  numero = new FormControl('', [Validators.required, Validators.max(16)] );

  constructor() { }

  ngOnInit(): void {
  }

}
