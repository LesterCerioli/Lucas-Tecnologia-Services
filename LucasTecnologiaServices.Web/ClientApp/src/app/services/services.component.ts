import { Component } from '@angular/core';

@Component({
  selector: 'app-services-component',
  templateUrl: './services.component.html'
})
export class ServicesComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
