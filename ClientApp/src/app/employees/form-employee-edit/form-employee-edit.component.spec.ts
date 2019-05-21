import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormEmployeeEditComponent } from './form-employee-edit.component';

describe('FormEmployeeEditComponent', () => {
  let component: FormEmployeeEditComponent;
  let fixture: ComponentFixture<FormEmployeeEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormEmployeeEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormEmployeeEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
