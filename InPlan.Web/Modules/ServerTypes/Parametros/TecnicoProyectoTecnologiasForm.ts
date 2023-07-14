import { LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TecnicoProyectoTecnologiasForm {
    IdTecnicoProyecto: LookupEditor;
    IdTecnologia: LookupEditor;
}

export class TecnicoProyectoTecnologiasForm extends PrefixedContext {
    static formKey = 'Parametros.TecnicoProyectoTecnologias';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TecnicoProyectoTecnologiasForm.init)  {
            TecnicoProyectoTecnologiasForm.init = true;

            var w0 = LookupEditor;

            initFormType(TecnicoProyectoTecnologiasForm, [
                'IdTecnicoProyecto', w0,
                'IdTecnologia', w0
            ]);
        }
    }
}