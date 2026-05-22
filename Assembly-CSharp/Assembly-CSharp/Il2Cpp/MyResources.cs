using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000137 RID: 311
	public class MyResources : MonoBehaviour
	{
		// Token: 0x0600265F RID: 9823 RVA: 0x0009ED70 File Offset: 0x0009CF70
		// Note: this type is marked as 'beforefieldinit'.
		static MyResources()
		{
			Il2CppClassPointerStore<MyResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MyResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyResources>.NativeClassPtr);
			MyResources.NativeFieldInfoPtr_stuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyResources>.NativeClassPtr, "stuff");
			MyResources.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyResources>.NativeClassPtr, "me");
			MyResources.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyResources>.NativeClassPtr, 100666354);
			MyResources.NativeMethodInfoPtr_Load_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyResources>.NativeClassPtr, 100666355);
			MyResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyResources>.NativeClassPtr, 100666356);
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x0009EE04 File Offset: 0x0009D004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74390, XrefRangeEnd = 74407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyResources.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x0009EE38 File Offset: 0x0009D038
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 74413, RefRangeEnd = 74437, XrefRangeStart = 74407, XrefRangeEnd = 74413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Load(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyResources.NativeMethodInfoPtr_Load_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x0009EE88 File Offset: 0x0009D088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MyResources()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyResources>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		public MyResources(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x0009EEC4 File Offset: 0x0009D0C4
		// (set) Token: 0x06002665 RID: 9829 RVA: 0x0001ACB1 File Offset: 0x00018EB1
		public unsafe Dictionary<string, Object> stuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyResources.NativeFieldInfoPtr_stuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyResources.NativeFieldInfoPtr_stuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x0009EEF4 File Offset: 0x0009D0F4
		// (set) Token: 0x06002667 RID: 9831 RVA: 0x0001ACD0 File Offset: 0x00018ED0
		public unsafe static MyResources me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MyResources.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MyResources>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MyResources.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeFieldInfoPtr_stuff;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Object_String_0;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
