using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000118 RID: 280
	public sealed class SemanticMeaning : ValueType
	{
		// Token: 0x0600173F RID: 5951 RVA: 0x00059F04 File Offset: 0x00058104
		// Note: this type is marked as 'beforefieldinit'.
		static SemanticMeaning()
		{
			Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "SemanticMeaning");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr);
			SemanticMeaning.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr, "key");
			SemanticMeaning.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr, "values");
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0000C6DA File Offset: 0x0000A8DA
		public SemanticMeaning(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0000C6E3 File Offset: 0x0000A8E3
		public SemanticMeaning()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr))
		{
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00059F5C File Offset: 0x0005815C
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x0000C6F5 File Offset: 0x0000A8F5
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00059F84 File Offset: 0x00058184
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x0000C714 File Offset: 0x0000A914
		public unsafe Il2CppStringArray values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeFieldInfoPtr_values;
	}
}
