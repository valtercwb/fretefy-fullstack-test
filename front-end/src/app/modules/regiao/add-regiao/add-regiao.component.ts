import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';
import { Cidade } from 'src/app/model/cidade.model';
import { Regiao } from 'src/app/model/regiao.model';

@Component({
  selector: 'app-add-regiao',
  templateUrl: './add-regiao.component.html',
  styleUrls: ['./add-regiao.component.scss']
})
export class AddRegiaoComponent implements OnInit {

  cidades: Array<Cidade> = [];

  submitted: false;
  public form: FormGroup;
  public regiao: Regiao;

  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    this.cidades.push(new Cidade());
    this.form = this.fb.group({
      nome: ['', Validators.required],
      regiaoCidade: [[]]
    });
  }

  get f() { return this.form.controls; }

  cadastrarRegiao(regiao: Regiao) {
    console.log(regiao)
  }

  addCidade() {
    this.cidades.push(new Cidade());
  }

  removerCidade(ele: any) {
    this.cidades.splice(-1);
  }
}
