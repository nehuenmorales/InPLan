import { IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AmbientesForm {
    IdEmpresa: IntegerEditor;
    IdArea: IntegerEditor;
    Descripcion: StringEditor;
    Observaciones: StringEditor;
    Baja: BooleanEditor;
}

export class AmbientesForm extends PrefixedContext {
    static formKey = 'Parametros.Ambientes';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AmbientesForm.init)  {
            AmbientesForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;

            initFormType(AmbientesForm, [
                'IdEmpresa', w0,
                'IdArea', w0,
                'Descripcion', w1,
                'Observaciones', w1,
                'Baja', w2
            ]);
        }
    }
}