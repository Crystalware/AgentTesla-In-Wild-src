using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System.My.Resources
{
	// Token: 0x02000009 RID: 9
	[StandardModule]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[HideModuleName]
	internal sealed class Resources
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004484 File Offset: 0x00002684
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ssnwpyqfwuivvv
		{
			get
			{
				bool flag = object.ReferenceEquals(Resources.resourceMan, null);
				if (flag)
				{
					for (;;)
					{
						IL_107:
						int num = Form2.uwpnsrqhswlmjh(34);
						int num2 = -20;
						for (;;)
						{
							num2 ^= 52;
							for (;;)
							{
								IL_66:
								int num3 = Form12.wsyoqrrjsoniul(40);
								int num4 = -13;
								for (;;)
								{
									num4 ^= 56;
									switch (num4 + 56)
									{
									case 0:
										goto IL_66;
									case 1:
										switch (num3 + 44)
										{
										case 0:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Resources.get_ssnwpyqfwuivvw()).MethodHandle;
											num3 = -6;
											goto IL_3E;
										}
										case 1:
											break;
										case 2:
											switch (num2 + 43)
											{
											case 0:
												goto IL_F3;
											case 1:
												goto IL_107;
											case 2:
												switch (num + 44)
												{
												case 0:
												{
													ResourceManager resourceManager = new ResourceManager("College_Management_System.Resources", typeof(Resources).Assembly);
													num = -6;
													goto IL_2B;
												}
												case 1:
												{
													ResourceManager resourceManager;
													Resources.resourceMan = resourceManager;
													num = -8;
													goto IL_2B;
												}
												case 2:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Resources.set_ssnwpyqfwuivvw(CultureInfo)).MethodHandle;
													num = Form12.wsyoqrrjsoniul(51);
													goto IL_2B;
												}
												case 3:
													goto IL_1B3;
												}
												goto Block_4;
											case 3:
												break;
											default:
												num3 = Form2.uwpnsrqhswlmjh(34);
												goto IL_3E;
											}
											IL_2B:
											num ^= 47;
											break;
										case 3:
											goto IL_EE;
										default:
											num4 = -16;
											continue;
										}
										num2 = Form12.wsyoqrrjsoniul(52);
										num3 = -7;
										goto IL_3E;
									case 2:
									{
										RuntimeMethodHandle runtimeMethodHandle3 = methodof(Resources.get_ssnwpyqfwuivvv()).MethodHandle;
										num4 = Form12.wsyoqrrjsoniul(53);
										continue;
									}
									case 3:
										goto IL_3E;
									}
									IL_5B:
									num4 = Form7.mqgfoefwabbyeu(23);
									continue;
									IL_3E:
									num3 ^= 46;
									goto IL_5B;
								}
							}
							IL_EE:
							continue;
							IL_F3:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Resources.get_ssnwpyqfwuivvx()).MethodHandle;
							num2 = Form2.uwpnsrqhswlmjh(47);
							continue;
							Block_4:
							num2 = -30;
						}
					}
					IL_1B3:;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00004658 File Offset: 0x00002858
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00004673 File Offset: 0x00002873
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo ssnwpyqfwuivvw
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00004680 File Offset: 0x00002880
		internal static Bitmap ssnwpyqfwuivvx
		{
			get
			{
				Bitmap result;
				for (;;)
				{
					IL_EA:
					int num = Form7.mqgfoefwabbyeu(31);
					int num2 = Form7.mqgfoefwabbyeu(21);
					for (;;)
					{
						num2 ^= 54;
						for (;;)
						{
							IL_54:
							int num3 = 14;
							int num4 = -13;
							for (;;)
							{
								num4 ^= 60;
								switch (num4 + 52)
								{
								case 0:
									switch (num3)
									{
									case 50:
										switch (num2 + 62)
										{
										case 0:
											switch (num + 61)
											{
											case 0:
											{
												object objectValue = RuntimeHelpers.GetObjectValue(Resources.ssnwpyqfwuivvv.GetObject("IApplicationTrustManager", Resources.resourceCulture));
												num = -6;
												goto IL_0B;
											}
											case 1:
											{
												object objectValue;
												result = (Bitmap)objectValue;
												num = -8;
												goto IL_0B;
											}
											case 2:
											{
												RuntimeMethodHandle runtimeMethodHandle = methodof(Resources.get_ssnwpyqfwuivvx()).MethodHandle;
												num = Form2.uwpnsrqhswlmjh(34);
												goto IL_0B;
											}
											case 3:
												return result;
											case 4:
												return result;
											}
											goto Block_2;
										case 1:
											goto IL_DC;
										case 2:
											goto IL_EA;
										case 3:
											break;
										default:
											num3 = 15;
											goto IL_1C;
										}
										IL_0B:
										num ^= 62;
										break;
									case 51:
										break;
									case 52:
									{
										RuntimeMethodHandle runtimeMethodHandle2 = methodof(Resources.get_ssnwpyqfwuivvx()).MethodHandle;
										num3 = 8;
										goto IL_1C;
									}
									case 53:
										goto IL_B2;
									default:
										num4 = -15;
										continue;
									}
									num2 = Form12.wsyoqrrjsoniul(58);
									num3 = 9;
									goto IL_1C;
								case 1:
									goto IL_54;
								case 2:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Resources.get_ssnwpyqfwuivvv()).MethodHandle;
									num4 = Form12.wsyoqrrjsoniul(53);
									continue;
								}
								case 3:
									goto IL_1C;
								}
								IL_39:
								num4 = Form7.mqgfoefwabbyeu(19);
								continue;
								IL_1C:
								num3 ^= 60;
								goto IL_39;
							}
						}
						IL_B2:
						continue;
						Block_2:
						num2 = -14;
						continue;
						IL_DC:
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Resources.get_ssnwpyqfwuivvw()).MethodHandle;
						num2 = -11;
					}
				}
				return result;
			}
		}

		// Token: 0x04000016 RID: 22
		private static ResourceManager resourceMan;

		// Token: 0x04000017 RID: 23
		private static CultureInfo resourceCulture;
	}
}
