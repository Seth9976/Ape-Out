using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000439 RID: 1081
	public sealed class Ephemeron : ValueType
	{
		// Token: 0x06004376 RID: 17270 RVA: 0x00138410 File Offset: 0x00136610
		// Note: this type is marked as 'beforefieldinit'.
		static Ephemeron()
		{
			Il2CppClassPointerStore<Ephemeron>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "Ephemeron");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr);
			Ephemeron.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr, "key");
			Ephemeron.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr, "value");
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x000199EB File Offset: 0x00017BEB
		public Ephemeron(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x000199F4 File Offset: 0x00017BF4
		public Ephemeron()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr))
		{
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x00138468 File Offset: 0x00136668
		// (set) Token: 0x0600437A RID: 17274 RVA: 0x00019A06 File Offset: 0x00017C06
		public unsafe Object key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x00138498 File Offset: 0x00136698
		// (set) Token: 0x0600437C RID: 17276 RVA: 0x00019A25 File Offset: 0x00017C25
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036C9 RID: 14025
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040036CA RID: 14026
		private static readonly IntPtr NativeFieldInfoPtr_value;
	}
}
