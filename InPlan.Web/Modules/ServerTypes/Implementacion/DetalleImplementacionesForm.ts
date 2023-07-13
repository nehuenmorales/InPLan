import { LookupEditor, StringEditor, DateEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface DetalleImplementacionesForm {
    IdImplementacion: LookupEditor;
    IdTecnicoResponsable: LookupEditor;
    Orden: StringEditor;
    DescripcionTarea: StringEditor;
    NotasAdicionales: StringEditor;
    DocumentosAdicionales: StringEditor;
    FechaInicio: DateEditor;
    FechaFinalizacion: DateEditor;
    Observaciones: StringEditor;
    IdEstadoTarea: IntegerEditor;
}

export class DetalleImplementacionesForm extends PrefixedContext {
    static formKey = 'Implementacion.DetalleImplementaciones';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DetalleImplementacionesForm.init)  {
            DetalleImplementacionesForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;
            var w3 = IntegerEditor;

            initFormType(DetalleImplementacionesForm, [
                'IdImplementacion', w0,
                'IdTecnicoResponsable', w0,
                'Orden', w1,
                'DescripcionTarea', w1,
                'NotasAdicionales', w1,
                'DocumentosAdicionales', w1,
                'FechaInicio', w2,
                'FechaFinalizacion', w2,
                'Observaciones', w1,
                'IdEstadoTarea', w3
            ]);
        }
    }
}