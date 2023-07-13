import { IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TecnicoProyectoTecnologiasForm {
    IdTecnicoProyecto: IntegerEditor;
    IdTecnologia: IntegerEditor;
}

export class TecnicoProyectoTecnologiasForm extends PrefixedContext {
    static formKey = 'Parametros.TecnicoProyectoTecnologias';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TecnicoProyectoTecnologiasForm.init)  {
            TecnicoProyectoTecnologiasForm.init = true;

            var w0 = IntegerEditor;

            initFormType(TecnicoProyectoTecnologiasForm, [
                'IdTecnicoProyecto', w0,
                'IdTecnologia', w0
            ]);
        }
    }
}