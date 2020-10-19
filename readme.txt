README for C# In Depth source code
----------------------------------

The source code for C# In Depth is laid out in the following manner:

MiscUtil.dll:  Required for most solutions, to allow easy starting
               of individual programs within projects.

Chapter12:     Source code for chapter 12 (various LINQ providers)
Snippy:        Source code for the "Snippy" snippet compiler
Snippets:      The snippets themselves
Databases:     Database files
OtherChapters: Code for chapters 1-11, 13-16

All code in the third edition requires Visual Studio 2012 to build;
in the second edition I had separate VS2010/VS008 solutions, but this
proved unwieldy moving forward. If you only have VS2010 or VS2008, you won't
be able to run the C# 5 examples anyway; the examples for earlier editions
of C# haven't changed significantly, so you should download the source code
from the second edition instead:
http://csharpindepth.com/Files/fullsource-2ndEdition.zip

Chapter 12 uses multiple projects to lay out their code;
the other chapters all have a single project per chapter, and so can
easily live within a single solution.

In some cases the code is slightly different from that in the book, in order
to use namespaces and type names which are more appropriate for types within
a full solution.

Each project uses MiscUtil as a launcher - set a project as the startup
project, run it, and you will be presented with options of which program to
run from within that project.

Note that Chapter12 has some NuGet package references; the packages themselves
are not present in the download - they should be fetched automatically when you
build, so long as "Allow NuGet to download missing packages during build" is
enabled. Alternatively, right-click on the solution in Solution Explorer, select
"Manage NuGet Packages..." and then click on the "Restore" button in the yellow
bar at the top of the dialog. See
http://docs.nuget.org/docs/Workflows/Using-NuGet-without-committing-packages
for more details. You'll need the NuGet package manager extension installed in
Visual Studio, of course.

Finally, if you're going to build Snippy you should first build a debug build of
the "OtherChapters" solution. Snippy has references to code in chapters 8, 11 and
13 so that you can easily access classes and data within those projects.
