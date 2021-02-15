using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000026 RID: 38
	[CompilerGenerated]
	[Guid("0000054D-0000-0010-8000-00AA006D2EA4")]
	[TypeIdentifier]
	[ComImport]
	public interface Fields20 : Fields15
	{
		// Token: 0x060002B7 RID: 695
		void _VtblGap1_3();

		// Token: 0x17000110 RID: 272
		[DispId(0)]
		Field this[[MarshalAs(UnmanagedType.Struct)] [In] object Index]
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}
	}
}
