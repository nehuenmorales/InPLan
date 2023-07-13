import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AmbientesProyectosColumns, AmbientesProyectosRow, AmbientesProyectosService } from '../../ServerTypes/Parametros';
import { AmbientesProyectosDialog } from './AmbientesProyectosDialog';

@Decorators.registerClass('InPlan.Parametros.AmbientesProyectosGrid')
export class AmbientesProyectosGrid extends EntityGrid<AmbientesProyectosRow, any> {
    protected getColumnsKey() { return AmbientesProyectosColumns.columnsKey; }
    protected getDialogType() { return AmbientesProyectosDialog; }
    protected getRowDefinition() { return AmbientesProyectosRow; }
    protected getService() { return AmbientesProyectosService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}