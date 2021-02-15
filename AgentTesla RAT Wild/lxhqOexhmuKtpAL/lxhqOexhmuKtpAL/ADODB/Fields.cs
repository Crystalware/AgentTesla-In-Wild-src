using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000024 RID: 36
	[CompilerGenerated]
	[Guid("00000564-0000-0010-8000-00AA006D2EA4")]
	[TypeIdentifier]
	[ComImport]
	public interface Fields : Fields20
	{
		// Token: 0x060002B3 RID: 691
		void _VtblGap1_3();

		// Token: 0x1700010E RID: 270
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
