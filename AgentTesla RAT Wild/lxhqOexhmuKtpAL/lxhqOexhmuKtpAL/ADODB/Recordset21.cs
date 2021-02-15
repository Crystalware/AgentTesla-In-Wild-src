using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200002B RID: 43
	[CompilerGenerated]
	[Guid("00000555-0000-0010-8000-00AA006D2EA4")]
	[DefaultMember("Fields")]
	[TypeIdentifier]
	[ComImport]
	public interface Recordset21 : Recordset20
	{
		// Token: 0x060002BD RID: 701
		void _VtblGap1_14();

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002BE RID: 702
		[DispId(0)]
		[IndexerName("Fields")]
		Fields Fields { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}
}
