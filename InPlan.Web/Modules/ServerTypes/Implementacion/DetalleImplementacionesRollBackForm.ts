import { LookupEditor, StringEditor, TextAreaEditor, DateEditor, MultipleImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface DetalleImplementacionesRollBackForm {
    IdImplementacion: LookupEditor;
    IdTecnicoResponsable: LookupEditor;
    IdEstadoTarea: LookupEditor;
    Orden: StringEditor;
    DescripcionTarea: TextAreaEditor;
    NotasAdicionales: TextAreaEditor;
    Observaciones: TextAreaEditor;
    FechaInicio: DateEditor;
    FechaFinalizacion: DateEditor;
    DocumentosAdicionales: MultipleImageUploadEditor;
}

export class DetalleImplementacionesRollBackForm extends PrefixedContext {
    static formKey = 'Implementacion.DetalleImplementacionesRollBack';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DetalleImplementacionesRollBackForm.init)  {
            DetalleImplementacionesRollBackForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = DateEditor;
            var w4 = MultipleImageUploadEditor;

            initFormType(DetalleImplementacionesRollBackForm, [
                'IdImplementacion', w0,
                'IdTecnicoResponsable', w0,
                'IdEstadoTarea', w0,
                'Orden', w1,
                'DescripcionTarea', w2,
                'NotasAdicionales', w2,
                'Observaciones', w2,
                'FechaInicio', w3,
                'FechaFinalizacion', w3,
                'DocumentosAdicionales', w4
            ]);
        }
    }
}