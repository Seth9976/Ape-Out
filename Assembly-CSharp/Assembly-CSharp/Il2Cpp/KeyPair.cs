using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000127 RID: 295
	public sealed class KeyPair : ValueType
	{
		// Token: 0x06002312 RID: 8978 RVA: 0x00095A48 File Offset: 0x00093C48
		// Note: this type is marked as 'beforefieldinit'.
		static KeyPair()
		{
			Il2CppClassPointerStore<KeyPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "KeyPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyPair>.NativeClassPtr);
			KeyPair.NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPair>.NativeClassPtr, "str");
			KeyPair.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPair>.NativeClassPtr, "key");
			KeyPair.NativeMethodInfoPtr__ctor_Public_Void_String_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPair>.NativeClassPtr, 100666023);
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00095AB4 File Offset: 0x00093CB4
		[CallerCount(0)]
		public unsafe KeyPair(string _str, KeyCode _key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyPair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPair.NativeMethodInfoPtr__ctor_Public_Void_String_KeyCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x0001892E File Offset: 0x00016B2E
		public KeyPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00018937 File Offset: 0x00016B37
		public KeyPair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyPair>.NativeClassPtr))
		{
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x00095B14 File Offset: 0x00093D14
		// (set) Token: 0x06002317 RID: 8983 RVA: 0x00018949 File Offset: 0x00016B49
		public unsafe string str
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPair.NativeFieldInfoPtr_str);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPair.NativeFieldInfoPtr_str), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00095B3C File Offset: 0x00093D3C
		// (set) Token: 0x06002319 RID: 8985 RVA: 0x00018968 File Offset: 0x00016B68
		public unsafe KeyCode key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPair.NativeFieldInfoPtr_key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPair.NativeFieldInfoPtr_key)) = value;
			}
		}

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeFieldInfoPtr_str;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_KeyCode_0;
	}
}
