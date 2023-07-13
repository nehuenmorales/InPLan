import { IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface EstadosTareasForm {
    IdEmpresa: IntegerEditor;
    IdArea: IntegerEditor;
    Descripcion: StringEditor;
    Observaciones: StringEditor;
    Baja: BooleanEditor;
}

export class EstadosTareasForm extends PrefixedContext {
    static formKey = 'Parametros.EstadosTareas';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EstadosTareasForm.init)  {
            EstadosTareasForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;

            initFormType(EstadosTareasForm, [
                'IdEmpresa', w0,
                'IdArea', w0,
                'Descripcion', w1,
                'Observaciones', w1,
                'Baja', w2
            ]);
        }
    }
}