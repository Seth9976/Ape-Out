using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000151 RID: 337
	public class PartKiller : MonoBehaviour
	{
		// Token: 0x060028AC RID: 10412 RVA: 0x000A49CC File Offset: 0x000A2BCC
		// Note: this type is marked as 'beforefieldinit'.
		static PartKiller()
		{
			Il2CppClassPointerStore<PartKiller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PartKiller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartKiller>.NativeClassPtr);
			PartKiller.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartKiller>.NativeClassPtr, "timer");
			PartKiller.NativeFieldInfoPtr_pSys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartKiller>.NativeClassPtr, "pSys");
			PartKiller.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartKiller>.NativeClassPtr, 100666511);
			PartKiller.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartKiller>.NativeClassPtr, 100666512);
			PartKiller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartKiller>.NativeClassPtr, 100666513);
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000A4A60 File Offset: 0x000A2C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76390, XrefRangeEnd = 76393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartKiller.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000A4A94 File Offset: 0x000A2C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76393, XrefRangeEnd = 76401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartKiller.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000A4AC8 File Offset: 0x000A2CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartKiller()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartKiller>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartKiller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0001C610 File Offset: 0x0001A810
		public PartKiller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000A4B04 File Offset: 0x000A2D04
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x0001C619 File Offset: 0x0001A819
		public unsafe int timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartKiller.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartKiller.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000A4B2C File Offset: 0x000A2D2C
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x0001C634 File Offset: 0x0001A834
		public unsafe ParticleSystem pSys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartKiller.NativeFieldInfoPtr_pSys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartKiller.NativeFieldInfoPtr_pSys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeFieldInfoPtr_pSys;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
