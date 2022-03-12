import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'calculadora';
  fullUrl = 'https://localhost:5001';
  resultado: any;
  n1 = 0;
  n2 = 0;
  constructor(private http: HttpClient) {


  }
  somar(){
    this.chamarApi("Somar");
  }

  multiplicar(){
    this.chamarApi("Multiplicar");
  }

  subtrair(){
    this.chamarApi("Subtrair");
  }

  dividir(){
    this.chamarApi("Dividir");
  }

  chamarApi(acao: string){
    var headers = new HttpHeaders();
    var httpOptions = {
      headers: headers
    }

    var body = {
      numero1: this.n1,
      numero2: this.n2
    };

    this.http.post(this.fullUrl + "/api/Calculadora/" + acao, body, httpOptions).subscribe( s=> {
      this.resultado = s;
    });
  }
}


