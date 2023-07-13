import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AreasGrid } from './AreasGrid';

export default function pageInit() {
    initFullHeightGridPage(new AreasGrid($('#GridDiv')).element);
}