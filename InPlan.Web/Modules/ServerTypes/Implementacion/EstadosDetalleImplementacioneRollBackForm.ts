import { IntegerEditor, DateEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface EstadosDetalleImplementacioneRollBackForm {
    IdDetalleImplementacionRollBack: IntegerEditor;
    IdEstadoTarea: IntegerEditor;
    IdTecnicoTarea: IntegerEditor;
    FechaEstado: DateEditor;
    FechaCarga: DateEditor;
    NotasAdicionales: StringEditor;
    DocumentosAdicionales: StringEditor;
    Observaciones: StringEditor;
    UserId: IntegerEditor;
}

export class EstadosDetalleImplementacioneRollBackForm extends PrefixedContext {
    static formKey = 'Implementacion.EstadosDetalleImplementacioneRollBack';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EstadosDetalleImplementacioneRollBackForm.init)  {
            EstadosDetalleImplementacioneRollBackForm.init = true;

            var w0 = IntegerEditor;
            var w1 = DateEditor;
            var w2 = StringEditor;

            initFormType(EstadosDetalleImplementacioneRollBackForm, [
                'IdDetalleImplementacionRollBack', w0,
                'IdEstadoTarea', w0,
                'IdTecnicoTarea', w0,
                'FechaEstado', w1,
                'FechaCarga', w1,
                'NotasAdicionales', w2,
                'DocumentosAdicionales', w2,
                'Observaciones', w2,
                'UserId', w0
            ]);
        }
    }
}