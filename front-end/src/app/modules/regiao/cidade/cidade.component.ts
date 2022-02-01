import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { CidadeService } from 'src/app/services/cidade.service';

interface Cidade {
  nome: string;
}

@Component({
  selector: 'app-cidade',
  templateUrl: './cidade.component.html',
  styleUrls: ['./cidade.component.scss']
})
export class CidadeComponent implements OnInit {

  constructor(private cidadeService: CidadeService) { }

  ngOnInit() {
    this.ListarCidade();
  }

  cidadeControl = new FormControl('', Validators.required);
  selectFormControl = new FormControl('', Validators.required);

  listaCidade: any;

  ListarCidade(): void {
    this.cidadeService.getAll()
      .subscribe(
        data => {
          this.listaCidade = data;
          console.log(data)
        },
        error => {
          console.log(error);
        });
  }
}
