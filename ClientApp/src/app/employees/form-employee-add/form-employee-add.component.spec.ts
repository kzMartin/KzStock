import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormEmployeeAddComponent } from './form-employee-add.component';

describe('FormEmployeeAddComponent', () => {
  let component: FormEmployeeAddComponent;
  let fixture: ComponentFixture<FormEmployeeAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormEmployeeAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormEmployeeAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
