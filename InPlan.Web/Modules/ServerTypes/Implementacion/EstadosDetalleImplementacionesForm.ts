import { LookupEditor, StringEditor, IntegerEditor, TextAreaEditor, DateEditor, MultipleImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface EstadosDetalleImplementacionesForm {
    IdDetalleImplementacion: LookupEditor;
    IdEstadoTarea: LookupEditor;
    IdTecnicoTarea: LookupEditor;
    NotasAdicionales: StringEditor;
    UserId: IntegerEditor;
    Observaciones: TextAreaEditor;
    FechaEstado: DateEditor;
    FechaCarga: DateEditor;
    DocumentosAdicionales: MultipleImageUploadEditor;
}

export class EstadosDetalleImplementacionesForm extends PrefixedContext {
    static formKey = 'Implementacion.EstadosDetalleImplementaciones';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EstadosDetalleImplementacionesForm.init)  {
            EstadosDetalleImplementacionesForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = IntegerEditor;
            var w3 = TextAreaEditor;
            var w4 = DateEditor;
            var w5 = MultipleImageUploadEditor;

            initFormType(EstadosDetalleImplementacionesForm, [
                'IdDetalleImplementacion', w0,
                'IdEstadoTarea', w0,
                'IdTecnicoTarea', w0,
                'NotasAdicionales', w1,
                'UserId', w2,
                'Observaciones', w3,
                'FechaEstado', w4,
                'FechaCarga', w4,
                'DocumentosAdicionales', w5
            ]);
        }
    }
}