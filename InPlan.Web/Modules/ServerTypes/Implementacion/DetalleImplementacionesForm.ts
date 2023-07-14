import { LookupEditor, StringEditor, TextAreaEditor, DateEditor, MultipleImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface DetalleImplementacionesForm {
    IdTecnicoResponsable: LookupEditor;
    Orden: StringEditor;
    DescripcionTarea: TextAreaEditor;
    FechaInicio: DateEditor;
    FechaFinalizacion: DateEditor;
    NotasAdicionales: StringEditor;
    IdEstadoTarea: LookupEditor;
    DocumentosAdicionales: MultipleImageUploadEditor;
    Observaciones: TextAreaEditor;
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
            var w2 = TextAreaEditor;
            var w3 = DateEditor;
            var w4 = MultipleImageUploadEditor;

            initFormType(DetalleImplementacionesForm, [
                'IdTecnicoResponsable', w0,
                'Orden', w1,
                'DescripcionTarea', w2,
                'FechaInicio', w3,
                'FechaFinalizacion', w3,
                'NotasAdicionales', w1,
                'IdEstadoTarea', w0,
                'DocumentosAdicionales', w4,
                'Observaciones', w2
            ]);
        }
    }
}