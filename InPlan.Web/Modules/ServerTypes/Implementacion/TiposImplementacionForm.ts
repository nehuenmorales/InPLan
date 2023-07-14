import { LookupEditor, StringEditor, TextAreaEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TiposImplementacionForm {
    IdEmpresa: LookupEditor;
    IdArea: LookupEditor;
    Descripcion: StringEditor;
    Observaciones: TextAreaEditor;
    Baja: BooleanEditor;
}

export class TiposImplementacionForm extends PrefixedContext {
    static formKey = 'Implementacion.TiposImplementacion';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TiposImplementacionForm.init)  {
            TiposImplementacionForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = BooleanEditor;

            initFormType(TiposImplementacionForm, [
                'IdEmpresa', w0,
                'IdArea', w0,
                'Descripcion', w1,
                'Observaciones', w2,
                'Baja', w3
            ]);
        }
    }
}