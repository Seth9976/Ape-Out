using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x020001E1 RID: 481
	public sealed class FlightPedalsTemplate : ControllerTemplate
	{
		// Token: 0x06003756 RID: 14166 RVA: 0x000CE2E4 File Offset: 0x000CC4E4
		// Note: this type is marked as 'beforefieldinit'.
		static FlightPedalsTemplate()
		{
			Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "FlightPedalsTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr);
			FlightPedalsTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, "typeGuid");
			FlightPedalsTemplate.NativeFieldInfoPtr_elementId_leftPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, "elementId_leftPedal");
			FlightPedalsTemplate.NativeFieldInfoPtr_elementId_rightPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, "elementId_rightPedal");
			FlightPedalsTemplate.NativeFieldInfoPtr_elementId_slide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, "elementId_slide");
			FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100667723);
			FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100667724);
			FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100667725);
			FlightPedalsTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100667726);
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06003757 RID: 14167 RVA: 0x000CE3B4 File Offset: 0x000CC5B4
		public unsafe IControllerTemplateAxis Rewired.IFlightPedalsTemplate.leftPedal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86811, XrefRangeEnd = 86814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x000CE3F4 File Offset: 0x000CC5F4
		public unsafe IControllerTemplateAxis Rewired.IFlightPedalsTemplate.rightPedal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86814, XrefRangeEnd = 86817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06003759 RID: 14169 RVA: 0x000CE434 File Offset: 0x000CC634
		public unsafe IControllerTemplateAxis Rewired.IFlightPedalsTemplate.slide
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86817, XrefRangeEnd = 86825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x000CE474 File Offset: 0x000CC674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlightPedalsTemplate(Object payload)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00023F48 File Offset: 0x00022148
		public FlightPedalsTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x0600375C RID: 14172 RVA: 0x000CE4C0 File Offset: 0x000CC6C0
		// (set) Token: 0x0600375D RID: 14173 RVA: 0x00023F51 File Offset: 0x00022151
		public unsafe static Guid typeGuid
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&value));
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x0600375E RID: 14174 RVA: 0x000CE4DC File Offset: 0x000CC6DC
		// (set) Token: 0x0600375F RID: 14175 RVA: 0x00023F5F File Offset: 0x0002215F
		public unsafe static int elementId_leftPedal
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_leftPedal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_leftPedal, (void*)(&value));
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06003760 RID: 14176 RVA: 0x000CE4F8 File Offset: 0x000CC6F8
		// (set) Token: 0x06003761 RID: 14177 RVA: 0x00023F6D File Offset: 0x0002216D
		public unsafe static int elementId_rightPedal
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_rightPedal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_rightPedal, (void*)(&value));
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06003762 RID: 14178 RVA: 0x000CE514 File Offset: 0x000CC714
		// (set) Token: 0x06003763 RID: 14179 RVA: 0x00023F7B File Offset: 0x0002217B
		public unsafe static int elementId_slide
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_slide, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_slide, (void*)(&value));
			}
		}

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeFieldInfoPtr_typeGuid;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftPedal;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightPedal;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeFieldInfoPtr_elementId_slide;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
	}
}
