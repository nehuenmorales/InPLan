import { LookupEditor, StringEditor, TextAreaEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AmbientesForm {
    IdEmpresa: LookupEditor;
    IdArea: LookupEditor;
    Descripcion: StringEditor;
    Observaciones: TextAreaEditor;
    Baja: BooleanEditor;
}

export class AmbientesForm extends PrefixedContext {
    static formKey = 'Parametros.Ambientes';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AmbientesForm.init)  {
            AmbientesForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = BooleanEditor;

            initFormType(AmbientesForm, [
                'IdEmpresa', w0,
                'IdArea', w0,
                'Descripcion', w1,
                'Observaciones', w2,
                'Baja', w3
            ]);
        }
    }
}