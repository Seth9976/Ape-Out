using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200015E RID: 350
	[Serializable]
	public class DecoderFallback : Object
	{
		// Token: 0x060017E1 RID: 6113 RVA: 0x0008FE3C File Offset: 0x0008E03C
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderFallback()
		{
			Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr);
			DecoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "bIsMicrosoftBestFitFallback");
			DecoderFallback.NativeFieldInfoPtr_replacementFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "replacementFallback");
			DecoderFallback.NativeFieldInfoPtr_exceptionFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "exceptionFallback");
			DecoderFallback.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "s_InternalSyncObject");
			DecoderFallback.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667344);
			DecoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667345);
			DecoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667346);
			DecoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667347);
			DecoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667348);
			DecoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100667349);
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0008FF34 File Offset: 0x0008E134
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 179225, RefRangeEnd = 179227, XrefRangeStart = 179218, XrefRangeEnd = 179225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x0008FF68 File Offset: 0x0008E168
		public unsafe static DecoderFallback ReplacementFallback
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 179242, RefRangeEnd = 179247, XrefRangeStart = 179227, XrefRangeEnd = 179242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x0008FF9C File Offset: 0x0008E19C
		public unsafe static DecoderFallback ExceptionFallback
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 179259, RefRangeEnd = 179262, XrefRangeStart = 179247, XrefRangeEnd = 179259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0008FFD0 File Offset: 0x0008E1D0
		[CallerCount(0)]
		public unsafe virtual DecoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0009001C File Offset: 0x0008E21C
		public unsafe virtual int MaxCharCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00090064 File Offset: 0x0008E264
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0000845F File Offset: 0x0000665F
		public DecoderFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x000900A0 File Offset: 0x0008E2A0
		// (set) Token: 0x060017EA RID: 6122 RVA: 0x00008468 File Offset: 0x00006668
		public unsafe bool bIsMicrosoftBestFitFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallback.NativeFieldInfoPtr_bIsMicrosoftBestFitFallback)) = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x000900C8 File Offset: 0x0008E2C8
		// (set) Token: 0x060017EC RID: 6124 RVA: 0x00008483 File Offset: 0x00006683
		public unsafe static DecoderFallback replacementFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecoderFallback.NativeFieldInfoPtr_replacementFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecoderFallback.NativeFieldInfoPtr_replacementFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x000900F0 File Offset: 0x0008E2F0
		// (set) Token: 0x060017EE RID: 6126 RVA: 0x00008495 File Offset: 0x00006695
		public unsafe static DecoderFallback exceptionFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecoderFallback.NativeFieldInfoPtr_exceptionFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecoderFallback.NativeFieldInfoPtr_exceptionFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x00090118 File Offset: 0x0008E318
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x000084A7 File Offset: 0x000066A7
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecoderFallback.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecoderFallback.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeFieldInfoPtr_bIsMicrosoftBestFitFallback;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeFieldInfoPtr_replacementFallback;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeFieldInfoPtr_exceptionFallback;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
