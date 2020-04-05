import { Component } from '@angular/core';

@Component({
  selector: 'app-login.component',
  templateUrl: './login.component.html'
})
export class LoginComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
