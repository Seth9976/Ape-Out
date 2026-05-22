using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000158 RID: 344
	public abstract class BaseShaderInfoStorage
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00007664 File Offset: 0x00005864
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00007671 File Offset: 0x00005871
		public bool disposed
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0000767E File Offset: 0x0000587E
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		public virtual void Dispose(bool disposing)
		{
			bool disposed = this.disposed;
			if (!disposed)
			{
				bool flag = !disposing;
				if (flag)
				{
				}
				this.disposed = true;
			}
		}
	}
}
