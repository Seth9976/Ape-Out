using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001CA RID: 458
	public class ExceptionHandlingClause : Object
	{
		// Token: 0x06001DA1 RID: 7585 RVA: 0x000A9A54 File Offset: 0x000A7C54
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionHandlingClause()
		{
			Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ExceptionHandlingClause");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr);
			ExceptionHandlingClause.NativeFieldInfoPtr_catch_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "catch_type");
			ExceptionHandlingClause.NativeFieldInfoPtr_filter_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "filter_offset");
			ExceptionHandlingClause.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "flags");
			ExceptionHandlingClause.NativeFieldInfoPtr_try_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "try_offset");
			ExceptionHandlingClause.NativeFieldInfoPtr_try_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "try_length");
			ExceptionHandlingClause.NativeFieldInfoPtr_handler_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "handler_offset");
			ExceptionHandlingClause.NativeFieldInfoPtr_handler_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, "handler_length");
			ExceptionHandlingClause.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, 100668295);
			ExceptionHandlingClause.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr, 100668296);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x000A9B38 File Offset: 0x000A7D38
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionHandlingClause()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExceptionHandlingClause>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHandlingClause.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x000A9B74 File Offset: 0x000A7D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187760, XrefRangeEnd = 187799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExceptionHandlingClause.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x0000A0CF File Offset: 0x000082CF
		public ExceptionHandlingClause(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x000A9BB8 File Offset: 0x000A7DB8
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x0000A0D8 File Offset: 0x000082D8
		public unsafe Type catch_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_catch_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_catch_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x000A9BE8 File Offset: 0x000A7DE8
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x0000A0F7 File Offset: 0x000082F7
		public unsafe int filter_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_filter_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_filter_offset)) = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x000A9C10 File Offset: 0x000A7E10
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0000A112 File Offset: 0x00008312
		public unsafe ExceptionHandlingClauseOptions flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x000A9C38 File Offset: 0x000A7E38
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0000A12D File Offset: 0x0000832D
		public unsafe int try_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_offset)) = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x000A9C60 File Offset: 0x000A7E60
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0000A148 File Offset: 0x00008348
		public unsafe int try_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_try_length)) = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x000A9C88 File Offset: 0x000A7E88
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x0000A163 File Offset: 0x00008363
		public unsafe int handler_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_offset)) = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x000A9CB0 File Offset: 0x000A7EB0
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x0000A17E File Offset: 0x0000837E
		public unsafe int handler_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionHandlingClause.NativeFieldInfoPtr_handler_length)) = value;
			}
		}

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeFieldInfoPtr_catch_type;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeFieldInfoPtr_filter_offset;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeFieldInfoPtr_try_offset;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeFieldInfoPtr_try_length;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeFieldInfoPtr_handler_offset;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeFieldInfoPtr_handler_length;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
