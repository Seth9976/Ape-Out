using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F0 RID: 240
	public sealed class WaitUntil : CustomYieldInstruction
	{
		// Token: 0x06001412 RID: 5138 RVA: 0x000513FC File Offset: 0x0004F5FC
		// Note: this type is marked as 'beforefieldinit'.
		static WaitUntil()
		{
			Il2CppClassPointerStore<WaitUntil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitUntil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr);
			WaitUntil.NativeFieldInfoPtr_m_Predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, "m_Predicate");
			WaitUntil.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100665069);
			WaitUntil.NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100665070);
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x00051468 File Offset: 0x0004F668
		public unsafe override bool keepWaiting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498351, XrefRangeEnd = 498354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitUntil.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x000514A4 File Offset: 0x0004F6A4
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitUntil(Func<bool> predicate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitUntil.NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0000B191 File Offset: 0x00009391
		public WaitUntil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x000514F0 File Offset: 0x0004F6F0
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x0000B19A File Offset: 0x0000939A
		public unsafe Func<bool> m_Predicate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_Predicate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_Predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeFieldInfoPtr_m_Predicate;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0;
	}
}
