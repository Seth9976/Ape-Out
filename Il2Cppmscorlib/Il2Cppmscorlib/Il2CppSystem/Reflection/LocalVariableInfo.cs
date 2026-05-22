using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001CC RID: 460
	public class LocalVariableInfo : Object
	{
		// Token: 0x06001DCD RID: 7629 RVA: 0x000AA614 File Offset: 0x000A8814
		// Note: this type is marked as 'beforefieldinit'.
		static LocalVariableInfo()
		{
			Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "LocalVariableInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr);
			LocalVariableInfo.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, "type");
			LocalVariableInfo.NativeFieldInfoPtr_is_pinned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, "is_pinned");
			LocalVariableInfo.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, "position");
			LocalVariableInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, 100668321);
			LocalVariableInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr, 100668322);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x000AA6A8 File Offset: 0x000A88A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalVariableInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalVariableInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariableInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000AA6E4 File Offset: 0x000A88E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187849, XrefRangeEnd = 187859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalVariableInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0000A1A2 File Offset: 0x000083A2
		public LocalVariableInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x000AA728 File Offset: 0x000A8928
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x0000A1AB File Offset: 0x000083AB
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x000AA758 File Offset: 0x000A8958
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x0000A1CA File Offset: 0x000083CA
		public unsafe bool is_pinned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_is_pinned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_is_pinned)) = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x000AA780 File Offset: 0x000A8980
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x0000A1E5 File Offset: 0x000083E5
		public unsafe ushort position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariableInfo.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeFieldInfoPtr_is_pinned;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
