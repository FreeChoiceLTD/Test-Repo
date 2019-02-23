import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less']
})
export class AppComponent {
  title = 'ClientApp';

  public isPressed: boolean = false;

  public values: string[];
  constructor(private http: HttpClient) {
    this.http.get('/Home/Values').subscribe(result => {
      this.values = result as string[];
    }, error => console.error(error));
  }

  public btnPressed = () =>  this.isPressed = !this.isPressed;



}
