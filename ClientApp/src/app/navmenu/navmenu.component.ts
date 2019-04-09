import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navmenu',
  templateUrl: './navmenu.component.html',
  styleUrls: ['./navmenu.component.scss']
})
export class NavmenuComponent implements OnInit {
  isExpanded = false;

  constructor() {}

  ngOnInit() {}

  expand() {
    this.isExpanded = !this.isExpanded;
  }
}
