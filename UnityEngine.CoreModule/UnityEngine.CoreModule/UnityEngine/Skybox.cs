using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000218 RID: 536
	public sealed class Skybox : Behaviour
	{
		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x00075B70 File Offset: 0x00073D70
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x00011824 File Offset: 0x0000FA24
		public Material material
		{
			get
			{
				IntPtr intPtr = Skybox.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				Skybox.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AF6 RID: 6902
		private static readonly Skybox.get_materialDelegate get_materialDelegateField = IL2CPP.ResolveICall<Skybox.get_materialDelegate>("UnityEngine.Skybox::get_material");

		// Token: 0x04001AF7 RID: 6903
		private static readonly Skybox.set_materialDelegate set_materialDelegateField = IL2CPP.ResolveICall<Skybox.set_materialDelegate>("UnityEngine.Skybox::set_material");

		// Token: 0x02000B42 RID: 2882
		// (Invoke) Token: 0x060034E4 RID: 13540
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000B43 RID: 2883
		// (Invoke) Token: 0x060034E6 RID: 13542
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);
	}
}
