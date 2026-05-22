using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B8 RID: 440
	[DefaultMember("Item")]
	[Serializable]
	public sealed class ParameterModifier : ValueType
	{
		// Token: 0x06001C89 RID: 7305 RVA: 0x00009ACE File Offset: 0x00007CCE
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterModifier()
		{
			Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ParameterModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr);
			ParameterModifier.NativeFieldInfoPtr__byRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr, "_byRef");
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00009B07 File Offset: 0x00007D07
		public ParameterModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00009B10 File Offset: 0x00007D10
		public ParameterModifier()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr))
		{
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x000A4FC0 File Offset: 0x000A31C0
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x00009B22 File Offset: 0x00007D22
		public unsafe Il2CppStructArray<bool> _byRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterModifier.NativeFieldInfoPtr__byRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterModifier.NativeFieldInfoPtr__byRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeFieldInfoPtr__byRef;
	}
}
