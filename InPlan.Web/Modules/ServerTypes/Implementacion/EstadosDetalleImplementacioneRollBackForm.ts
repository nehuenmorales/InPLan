import { LookupEditor, DateEditor, TextAreaEditor, IntegerEditor, MultipleImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface EstadosDetalleImplementacioneRollBackForm {
    IdDetalleImplementacionRollBack: LookupEditor;
    IdEstadoTarea: LookupEditor;
    IdTecnicoTarea: LookupEditor;
    FechaEstado: DateEditor;
    FechaCarga: DateEditor;
    NotasAdicionales: TextAreaEditor;
    Observaciones: TextAreaEditor;
    UserId: IntegerEditor;
    DocumentosAdicionales: MultipleImageUploadEditor;
}

export class EstadosDetalleImplementacioneRollBackForm extends PrefixedContext {
    static formKey = 'Implementacion.EstadosDetalleImplementacioneRollBack';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EstadosDetalleImplementacioneRollBackForm.init)  {
            EstadosDetalleImplementacioneRollBackForm.init = true;

            var w0 = LookupEditor;
            var w1 = DateEditor;
            var w2 = TextAreaEditor;
            var w3 = IntegerEditor;
            var w4 = MultipleImageUploadEditor;

            initFormType(EstadosDetalleImplementacioneRollBackForm, [
                'IdDetalleImplementacionRollBack', w0,
                'IdEstadoTarea', w0,
                'IdTecnicoTarea', w0,
                'FechaEstado', w1,
                'FechaCarga', w1,
                'NotasAdicionales', w2,
                'Observaciones', w2,
                'UserId', w3,
                'DocumentosAdicionales', w4
            ]);
        }
    }
}