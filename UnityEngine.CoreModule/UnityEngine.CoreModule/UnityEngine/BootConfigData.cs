using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000048 RID: 72
	public class BootConfigData : Object
	{
		// Token: 0x0600028D RID: 653 RVA: 0x0001B560 File Offset: 0x00019760
		// Note: this type is marked as 'beforefieldinit'.
		static BootConfigData()
		{
			Il2CppClassPointerStore<BootConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BootConfigData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr);
			BootConfigData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, "m_Ptr");
			BootConfigData.NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, 100663479);
			BootConfigData.AppendDelegateField = IL2CPP.ResolveICall<BootConfigData.AppendDelegate>("UnityEngine.BootConfigData::Append");
			BootConfigData.SetDelegateField = IL2CPP.ResolveICall<BootConfigData.SetDelegate>("UnityEngine.BootConfigData::Set");
			BootConfigData.GetValueDelegateField = IL2CPP.ResolveICall<BootConfigData.GetValueDelegate>("UnityEngine.BootConfigData::GetValue");
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001B5E8 File Offset: 0x000197E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486240, XrefRangeEnd = 486244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BootConfigData WrapBootConfigData(IntPtr nativeHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BootConfigData.NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BootConfigData>(intPtr3) : null;
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000036B3 File Offset: 0x000018B3
		public BootConfigData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0001B628 File Offset: 0x00019828
		// (set) Token: 0x06000291 RID: 657 RVA: 0x000036BC File Offset: 0x000018BC
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BootConfigData.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BootConfigData.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000036D7 File Offset: 0x000018D7
		public void AddKey(string key)
		{
			this.Append(key, null);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0001B650 File Offset: 0x00019850
		public string Get(string key)
		{
			return this.GetValue(key, 0);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001B66C File Offset: 0x0001986C
		public string Get(string key, int index)
		{
			return this.GetValue(key, index);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000036E3 File Offset: 0x000018E3
		public void Append(string key, string value)
		{
			BootConfigData.AppendDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00003701 File Offset: 0x00001901
		public void Set(string key, string value)
		{
			BootConfigData.SetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001B688 File Offset: 0x00019888
		public string GetValue(string key, int index)
		{
			IntPtr intPtr = BootConfigData.GetValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), index);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0;

		// Token: 0x04000214 RID: 532
		private static readonly BootConfigData.AppendDelegate AppendDelegateField;

		// Token: 0x04000215 RID: 533
		private static readonly BootConfigData.SetDelegate SetDelegateField;

		// Token: 0x04000216 RID: 534
		private static readonly BootConfigData.GetValueDelegate GetValueDelegateField;

		// Token: 0x02000368 RID: 872
		// (Invoke) Token: 0x060024F7 RID: 9463
		private delegate void AppendDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x02000369 RID: 873
		// (Invoke) Token: 0x060024F9 RID: 9465
		private delegate void SetDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x0200036A RID: 874
		// (Invoke) Token: 0x060024FB RID: 9467
		private delegate IntPtr GetValueDelegate(IntPtr @this, IntPtr key, int index);
	}
}
