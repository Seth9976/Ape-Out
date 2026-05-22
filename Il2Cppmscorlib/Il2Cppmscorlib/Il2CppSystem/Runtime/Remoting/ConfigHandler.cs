using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Xml;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000397 RID: 919
	public class ConfigHandler : Object
	{
		// Token: 0x06003CBF RID: 15551 RVA: 0x00120304 File Offset: 0x0011E504
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigHandler()
		{
			Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ConfigHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr);
			ConfigHandler.NativeFieldInfoPtr_typeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "typeEntries");
			ConfigHandler.NativeFieldInfoPtr_channelInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "channelInstances");
			ConfigHandler.NativeFieldInfoPtr_currentChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentChannel");
			ConfigHandler.NativeFieldInfoPtr_currentProviderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentProviderData");
			ConfigHandler.NativeFieldInfoPtr_currentClientUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentClientUrl");
			ConfigHandler.NativeFieldInfoPtr_appName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "appName");
			ConfigHandler.NativeFieldInfoPtr_currentXmlPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentXmlPath");
			ConfigHandler.NativeFieldInfoPtr_onlyDelayedChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "onlyDelayedChannels");
			ConfigHandler.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672320);
			ConfigHandler.NativeMethodInfoPtr_ValidatePath_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672321);
			ConfigHandler.NativeMethodInfoPtr_CheckPath_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672322);
			ConfigHandler.NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672323);
			ConfigHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672324);
			ConfigHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672325);
			ConfigHandler.NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672326);
			ConfigHandler.NativeMethodInfoPtr_ParseElement_Public_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672327);
			ConfigHandler.NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672328);
			ConfigHandler.NativeMethodInfoPtr_ReadCustomProviderData_Private_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672329);
			ConfigHandler.NativeMethodInfoPtr_ReadLifetine_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672330);
			ConfigHandler.NativeMethodInfoPtr_ParseTime_Private_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672331);
			ConfigHandler.NativeMethodInfoPtr_ReadChannel_Private_Void_IAttrList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672332);
			ConfigHandler.NativeMethodInfoPtr_ReadProvider_Private_ProviderData_String_IAttrList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672333);
			ConfigHandler.NativeMethodInfoPtr_ReadClientActivated_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672334);
			ConfigHandler.NativeMethodInfoPtr_ReadServiceActivated_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672335);
			ConfigHandler.NativeMethodInfoPtr_ReadClientWellKnown_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672336);
			ConfigHandler.NativeMethodInfoPtr_ReadServiceWellKnown_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672337);
			ConfigHandler.NativeMethodInfoPtr_ReadInteropXml_Private_Void_IAttrList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672338);
			ConfigHandler.NativeMethodInfoPtr_ReadPreload_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672339);
			ConfigHandler.NativeMethodInfoPtr_GetNotNull_Private_String_IAttrList_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672340);
			ConfigHandler.NativeMethodInfoPtr_ExtractAssembly_Private_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672341);
			ConfigHandler.NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672342);
			ConfigHandler.NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672343);
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x001205B4 File Offset: 0x0011E7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219672, XrefRangeEnd = 219681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigHandler(bool onlyDelayedChannels)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyDelayedChannels;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x001205FC File Offset: 0x0011E7FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219683, RefRangeEnd = 219685, XrefRangeStart = 219681, XrefRangeEnd = 219683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidatePath(string element, [Optional] Il2CppStringArray paths)
		{
			if (paths == null)
			{
				paths = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ValidatePath_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00120660 File Offset: 0x0011E860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219695, RefRangeEnd = 219697, XrefRangeStart = 219685, XrefRangeEnd = 219695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckPath(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_CheckPath_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x001206B0 File Offset: 0x0011E8B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartParsing(SmallXmlParser parser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x001206F4 File Offset: 0x0011E8F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnProcessingInstruction(string name, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x00120748 File Offset: 0x0011E948
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnIgnorableWhitespace(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x0012078C File Offset: 0x0011E98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219697, XrefRangeEnd = 219704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x001207E0 File Offset: 0x0011E9E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219806, RefRangeEnd = 219807, XrefRangeStart = 219704, XrefRangeEnd = 219806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElement(string name, SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ParseElement_Public_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x00120834 File Offset: 0x0011EA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219807, XrefRangeEnd = 219809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x00120878 File Offset: 0x0011EA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219809, XrefRangeEnd = 219836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadCustomProviderData_Private_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x001208CC File Offset: 0x0011EACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219836, XrefRangeEnd = 219890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadLifetine(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadLifetine_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x00120910 File Offset: 0x0011EB10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219921, RefRangeEnd = 219925, XrefRangeStart = 219890, XrefRangeEnd = 219921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan ParseTime(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ParseTime_Private_TimeSpan_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x00120960 File Offset: 0x0011EB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219925, XrefRangeEnd = 219978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTemplate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadChannel_Private_Void_IAttrList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x001209B0 File Offset: 0x0011EBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219978, XrefRangeEnd = 220022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTemplate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadProvider_Private_ProviderData_String_IAttrList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProviderData>(intPtr3) : null;
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00120A20 File Offset: 0x0011EC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220022, XrefRangeEnd = 220032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadClientActivated(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadClientActivated_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x00120A64 File Offset: 0x0011EC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220032, XrefRangeEnd = 220040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadServiceActivated(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadServiceActivated_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x00120AA8 File Offset: 0x0011ECA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220040, XrefRangeEnd = 220051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadClientWellKnown(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadClientWellKnown_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x00120AEC File Offset: 0x0011ECEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220051, XrefRangeEnd = 220070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadServiceWellKnown_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x00120B30 File Offset: 0x0011ED30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220070, XrefRangeEnd = 220093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadInteropXml_Private_Void_IAttrList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x00120B80 File Offset: 0x0011ED80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220121, RefRangeEnd = 220122, XrefRangeStart = 220093, XrefRangeEnd = 220121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPreload(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadPreload_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x00120BC4 File Offset: 0x0011EDC4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 220127, RefRangeEnd = 220137, XrefRangeStart = 220122, XrefRangeEnd = 220127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNotNull(SmallXmlParser.IAttrList attrs, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_GetNotNull_Private_String_IAttrList_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00120C20 File Offset: 0x0011EE20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220143, RefRangeEnd = 220148, XrefRangeStart = 220137, XrefRangeEnd = 220143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ExtractAssembly(ref string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(type);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ExtractAssembly_Private_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				type = IL2CPP.Il2CppStringToManaged(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x00120C78 File Offset: 0x0011EE78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnChars(string ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x00120CBC File Offset: 0x0011EEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220148, XrefRangeEnd = 220162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndParsing(SmallXmlParser parser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x00016A8D File Offset: 0x00014C8D
		public void ValidatePath(string element, params string[] paths)
		{
			this.ValidatePath(element, new Il2CppStringArray(paths));
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x00016A9C File Offset: 0x00014C9C
		public ConfigHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x00120D00 File Offset: 0x0011EF00
		// (set) Token: 0x06003CDB RID: 15579 RVA: 0x00016AA5 File Offset: 0x00014CA5
		public unsafe ArrayList typeEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_typeEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_typeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x00120D30 File Offset: 0x0011EF30
		// (set) Token: 0x06003CDD RID: 15581 RVA: 0x00016AC4 File Offset: 0x00014CC4
		public unsafe ArrayList channelInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_channelInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_channelInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06003CDE RID: 15582 RVA: 0x00120D60 File Offset: 0x0011EF60
		// (set) Token: 0x06003CDF RID: 15583 RVA: 0x00016AE3 File Offset: 0x00014CE3
		public unsafe ChannelData currentChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentChannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentChannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06003CE0 RID: 15584 RVA: 0x00120D90 File Offset: 0x0011EF90
		// (set) Token: 0x06003CE1 RID: 15585 RVA: 0x00016B02 File Offset: 0x00014D02
		public unsafe Stack currentProviderData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentProviderData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentProviderData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x00120DC0 File Offset: 0x0011EFC0
		// (set) Token: 0x06003CE3 RID: 15587 RVA: 0x00016B21 File Offset: 0x00014D21
		public unsafe string currentClientUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentClientUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentClientUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x00120DE8 File Offset: 0x0011EFE8
		// (set) Token: 0x06003CE5 RID: 15589 RVA: 0x00016B40 File Offset: 0x00014D40
		public unsafe string appName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_appName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_appName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x00120E10 File Offset: 0x0011F010
		// (set) Token: 0x06003CE7 RID: 15591 RVA: 0x00016B5F File Offset: 0x00014D5F
		public unsafe string currentXmlPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentXmlPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentXmlPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06003CE8 RID: 15592 RVA: 0x00120E38 File Offset: 0x0011F038
		// (set) Token: 0x06003CE9 RID: 15593 RVA: 0x00016B7E File Offset: 0x00014D7E
		public unsafe bool onlyDelayedChannels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_onlyDelayedChannels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_onlyDelayedChannels)) = value;
			}
		}

		// Token: 0x04003270 RID: 12912
		private static readonly IntPtr NativeFieldInfoPtr_typeEntries;

		// Token: 0x04003271 RID: 12913
		private static readonly IntPtr NativeFieldInfoPtr_channelInstances;

		// Token: 0x04003272 RID: 12914
		private static readonly IntPtr NativeFieldInfoPtr_currentChannel;

		// Token: 0x04003273 RID: 12915
		private static readonly IntPtr NativeFieldInfoPtr_currentProviderData;

		// Token: 0x04003274 RID: 12916
		private static readonly IntPtr NativeFieldInfoPtr_currentClientUrl;

		// Token: 0x04003275 RID: 12917
		private static readonly IntPtr NativeFieldInfoPtr_appName;

		// Token: 0x04003276 RID: 12918
		private static readonly IntPtr NativeFieldInfoPtr_currentXmlPath;

		// Token: 0x04003277 RID: 12919
		private static readonly IntPtr NativeFieldInfoPtr_onlyDelayedChannels;

		// Token: 0x04003278 RID: 12920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04003279 RID: 12921
		private static readonly IntPtr NativeMethodInfoPtr_ValidatePath_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x0400327A RID: 12922
		private static readonly IntPtr NativeMethodInfoPtr_CheckPath_Private_Boolean_String_0;

		// Token: 0x0400327B RID: 12923
		private static readonly IntPtr NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0;

		// Token: 0x0400327C RID: 12924
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x0400327D RID: 12925
		private static readonly IntPtr NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x0400327E RID: 12926
		private static readonly IntPtr NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0;

		// Token: 0x0400327F RID: 12927
		private static readonly IntPtr NativeMethodInfoPtr_ParseElement_Public_Void_String_IAttrList_0;

		// Token: 0x04003280 RID: 12928
		private static readonly IntPtr NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04003281 RID: 12929
		private static readonly IntPtr NativeMethodInfoPtr_ReadCustomProviderData_Private_Void_String_IAttrList_0;

		// Token: 0x04003282 RID: 12930
		private static readonly IntPtr NativeMethodInfoPtr_ReadLifetine_Private_Void_IAttrList_0;

		// Token: 0x04003283 RID: 12931
		private static readonly IntPtr NativeMethodInfoPtr_ParseTime_Private_TimeSpan_String_0;

		// Token: 0x04003284 RID: 12932
		private static readonly IntPtr NativeMethodInfoPtr_ReadChannel_Private_Void_IAttrList_Boolean_0;

		// Token: 0x04003285 RID: 12933
		private static readonly IntPtr NativeMethodInfoPtr_ReadProvider_Private_ProviderData_String_IAttrList_Boolean_0;

		// Token: 0x04003286 RID: 12934
		private static readonly IntPtr NativeMethodInfoPtr_ReadClientActivated_Private_Void_IAttrList_0;

		// Token: 0x04003287 RID: 12935
		private static readonly IntPtr NativeMethodInfoPtr_ReadServiceActivated_Private_Void_IAttrList_0;

		// Token: 0x04003288 RID: 12936
		private static readonly IntPtr NativeMethodInfoPtr_ReadClientWellKnown_Private_Void_IAttrList_0;

		// Token: 0x04003289 RID: 12937
		private static readonly IntPtr NativeMethodInfoPtr_ReadServiceWellKnown_Private_Void_IAttrList_0;

		// Token: 0x0400328A RID: 12938
		private static readonly IntPtr NativeMethodInfoPtr_ReadInteropXml_Private_Void_IAttrList_Boolean_0;

		// Token: 0x0400328B RID: 12939
		private static readonly IntPtr NativeMethodInfoPtr_ReadPreload_Private_Void_IAttrList_0;

		// Token: 0x0400328C RID: 12940
		private static readonly IntPtr NativeMethodInfoPtr_GetNotNull_Private_String_IAttrList_String_0;

		// Token: 0x0400328D RID: 12941
		private static readonly IntPtr NativeMethodInfoPtr_ExtractAssembly_Private_String_byref_String_0;

		// Token: 0x0400328E RID: 12942
		private static readonly IntPtr NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x0400328F RID: 12943
		private static readonly IntPtr NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0;
	}
}
