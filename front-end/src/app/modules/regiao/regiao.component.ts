import { Component, OnInit } from '@angular/core';
import { RegiaoService } from 'src/app/services/regiao.service';
import { Router } from '@angular/router';
import { TipoStatus } from 'src/app/shared/tipo-status.enum';

@Component({
  selector: 'app-regiao',
  templateUrl: './regiao.component.html',
  styleUrls: ['./regiao.component.scss']
})

export class RegiaoComponent implements OnInit {

  public tipoStatus: TipoStatus;
  listaRegiao: any;

  constructor(private regiaoService: RegiaoService, private router: Router) { }

  ngOnInit() {
    this.ListarRegiao();
  }

  ListarRegiao(): void {
    this.regiaoService.getAll()
      .subscribe(
        data => {
          this.listaRegiao = data;
        },
        error => {
          console.log(error);
        });
  }
}
