using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000C8 RID: 200
	public class MyPart : global::Il2CppSystem.Object
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x00075AE0 File Offset: 0x00073CE0
		// Note: this type is marked as 'beforefieldinit'.
		static MyPart()
		{
			Il2CppClassPointerStore<MyPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MyPart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPart>.NativeClassPtr);
			MyPart.NativeFieldInfoPtr_dom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPart>.NativeClassPtr, "dom");
			MyPart.NativeFieldInfoPtr_sub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPart>.NativeClassPtr, "sub");
			MyPart.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPart>.NativeClassPtr, "trans");
			MyPart.NativeMethodInfoPtr__ctor_Public_Void_ParticleSystem_ParticleSystem_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPart>.NativeClassPtr, 100665232);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00075B60 File Offset: 0x00073D60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 56607, RefRangeEnd = 56610, XrefRangeStart = 56603, XrefRangeEnd = 56607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MyPart(ParticleSystem _main, ParticleSystem _sub, Transform _trans)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPart>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_main);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_sub);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_trans);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyPart.NativeMethodInfoPtr__ctor_Public_Void_ParticleSystem_ParticleSystem_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00010A45 File Offset: 0x0000EC45
		public MyPart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00075BD0 File Offset: 0x00073DD0
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x00010A4E File Offset: 0x0000EC4E
		public unsafe ParticleSystem dom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyPart.NativeFieldInfoPtr_dom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyPart.NativeFieldInfoPtr_dom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00075C00 File Offset: 0x00073E00
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x00010A6D File Offset: 0x0000EC6D
		public unsafe ParticleSystem sub
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyPart.NativeFieldInfoPtr_sub);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyPart.NativeFieldInfoPtr_sub), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00075C30 File Offset: 0x00073E30
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x00010A8C File Offset: 0x0000EC8C
		public unsafe Transform trans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyPart.NativeFieldInfoPtr_trans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyPart.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeFieldInfoPtr_dom;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeFieldInfoPtr_sub;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeFieldInfoPtr_trans;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ParticleSystem_ParticleSystem_Transform_0;
	}
}
