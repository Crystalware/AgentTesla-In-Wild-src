using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000027 RID: 39
	[CompilerGenerated]
	[Guid("0000051D-0000-0010-8000-00AA006D2EA4")]
	[TypeIdentifier("b691e011-1797-432e-907a-4d8c69339129", "ADODB.LockTypeEnum")]
	public enum LockTypeEnum
	{
		// Token: 0x04000145 RID: 325
		adLockUnspecified = -1,
		// Token: 0x04000146 RID: 326
		adLockReadOnly = 1,
		// Token: 0x04000147 RID: 327
		adLockPessimistic,
		// Token: 0x04000148 RID: 328
		adLockOptimistic,
		// Token: 0x04000149 RID: 329
		adLockBatchOptimistic
	}
}
