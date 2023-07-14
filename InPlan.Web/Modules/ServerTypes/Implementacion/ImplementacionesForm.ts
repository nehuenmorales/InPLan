import { LookupEditor, StringEditor, TextAreaEditor, DateEditor, IntegerEditor, MultipleImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { DetalleImplementacionesEditor } from "@/Implementacion/DetalleImplementaciones/DetalleImplementacionesEditor";
import { initFormType } from "@serenity-is/corelib/q";

export interface ImplementacionesForm {
    IdProyecto: LookupEditor;
    IdAmbienteProyecto: LookupEditor;
    IdTipoImplementacion: LookupEditor;
    NroTicket: StringEditor;
    Descripcion: TextAreaEditor;
    IdTecnicoSolicitante: LookupEditor;
    IdTecnicoImplementa: LookupEditor;
    FechaSolicitud: DateEditor;
    FechaPlanificada: DateEditor;
    FechaImplementacion: DateEditor;
    ConsideracionesPrevias: TextAreaEditor;
    ConsideracionesPosteriores: TextAreaEditor;
    NotasAdicionales: StringEditor;
    Observaciones: TextAreaEditor;
    UserId: IntegerEditor;
    DetallesList: DetalleImplementacionesEditor;
    DocumentosAdicionales: MultipleImageUploadEditor;
}

export class ImplementacionesForm extends PrefixedContext {
    static formKey = 'Implementacion.Implementaciones';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ImplementacionesForm.init)  {
            ImplementacionesForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = DateEditor;
            var w4 = IntegerEditor;
            var w5 = DetalleImplementacionesEditor;
            var w6 = MultipleImageUploadEditor;

            initFormType(ImplementacionesForm, [
                'IdProyecto', w0,
                'IdAmbienteProyecto', w0,
                'IdTipoImplementacion', w0,
                'NroTicket', w1,
                'Descripcion', w2,
                'IdTecnicoSolicitante', w0,
                'IdTecnicoImplementa', w0,
                'FechaSolicitud', w3,
                'FechaPlanificada', w3,
                'FechaImplementacion', w3,
                'ConsideracionesPrevias', w2,
                'ConsideracionesPosteriores', w2,
                'NotasAdicionales', w1,
                'Observaciones', w2,
                'UserId', w4,
                'DetallesList', w5,
                'DocumentosAdicionales', w6
            ]);
        }
    }
}